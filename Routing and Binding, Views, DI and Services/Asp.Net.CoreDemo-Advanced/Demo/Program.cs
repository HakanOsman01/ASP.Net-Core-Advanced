namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../six.png";
            EncrypthFile(path);
            string filePathDecrypth = "../../../six.pngencodedSis.png";
            DecrypthFile(filePathDecrypth,256);
            
                  

        }
        static void EncrypthFile (string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                byte[] buffer = new byte[1024];
                stream.Read(buffer, 0, buffer.Length);
                using (FileStream writeStream = new FileStream
                    (path + "encodedSis.png", FileMode.Create))
                {
                    byte[]writeBuffer= new byte[1024];
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        writeBuffer[i] = (byte)(buffer[i] ^ 256);

                    }
                    writeStream.Write(writeBuffer, 0, writeBuffer.Length);
                }
               

            }
          
        }
        static void DecrypthFile(string path,int solt)
        {
            using(var readStream=new FileStream(path, FileMode.Open))
            {
                byte[]buffer=new byte[1024];    
                readStream.Read(buffer, 0, buffer.Length);
                using( var writeStream=new FileStream(path+"decripth.png", FileMode.Create))
                {
                    byte[]writeBuffer= new byte[1024];
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        writeBuffer[i] = (byte)(buffer[i] | solt);
                    }
                    writeStream.Write(buffer, 0, writeBuffer.Length);
                }
            }
        }
    }
}