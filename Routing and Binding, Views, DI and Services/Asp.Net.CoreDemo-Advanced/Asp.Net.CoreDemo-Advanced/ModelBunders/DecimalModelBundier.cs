using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;

namespace Asp.Net.CoreDemo_Advanced.ModelBunders
{
    public class DecimalModelBundier : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            ValueProviderResult valueResult = bindingContext.ValueProvider
                .GetValue(bindingContext.ModelName);
            if (valueResult != ValueProviderResult.None && 
                !string.IsNullOrEmpty(valueResult.FirstValue))
            {
                decimal result = 0M;
                bool succes = false;
                try
                {
                    string strValue= valueResult.FirstValue.Trim();
                    strValue.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                    strValue.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                    result = Convert.ToDecimal(strValue, CultureInfo.CurrentCulture);
                    succes = true;

                }
                catch (FormatException fe)
                {
                    bindingContext.ModelState.AddModelError(bindingContext.ModelName,fe,bindingContext.ModelMetadata);

                }
                if(succes)
                {
                    bindingContext.Result = ModelBindingResult.Success(result);
                }
            }
            return Task.CompletedTask;
        }
    }
}
