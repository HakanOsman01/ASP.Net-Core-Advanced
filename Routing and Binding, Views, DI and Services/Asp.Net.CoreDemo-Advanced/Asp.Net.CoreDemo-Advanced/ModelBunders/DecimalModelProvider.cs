using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Asp.Net.CoreDemo_Advanced.ModelBunders
{
    public class DecimalModelProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            if (context.Metadata.ModelType == typeof(decimal) 
                || context.Metadata.ModelType==typeof(decimal?))
            {
                return new DecimalModelBundier();
            }
            return null;
        }
    }
}
