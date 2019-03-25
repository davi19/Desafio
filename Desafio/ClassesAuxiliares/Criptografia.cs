using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace Desafio.Classes
{
    class Criptografia
    {
        private static byte[] bIV =
        { 0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18,
            0x44, 0x74, 0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC };
   
        private const string chave =
            "Q3JpcHRvZ3JhZmlhcyBjb20gUmluamRhZWwgLyBBRVM=";

        public  string Criptografa(string valor)
        {

            try
            {
                if (!string.IsNullOrEmpty(valor))
                {
            
                    byte[] chaveBytes = Convert.FromBase64String(chave);
                    byte[] valorBytes = new UTF8Encoding().GetBytes(valor);

                    Rijndael rijndael = new RijndaelManaged();
               
                    rijndael.KeySize = 256;
             
                    MemoryStream stream = new MemoryStream();             
                    CryptoStream encriptador = new CryptoStream(
                        stream,
                        rijndael.CreateEncryptor(chaveBytes, bIV),
                        CryptoStreamMode.Write);

                    encriptador.Write(valorBytes, 0, valorBytes.Length);               
                    encriptador.FlushFinalBlock();
                    return Convert.ToBase64String(stream.ToArray());
                }
                else
                {            
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao criptografar", ex);
            }
        }

        public string Descriptografa(string valor)
        {
            try
            {       
                if (!string.IsNullOrEmpty(valor))
                {
                    byte[] chaveByte = Convert.FromBase64String(chave);
                    byte[] valorByte = Convert.FromBase64String(valor);

                                 
                    Rijndael rijndael = new RijndaelManaged();
             
                    rijndael.KeySize = 256;

                    
                    MemoryStream stream = new MemoryStream();               
                    CryptoStream descriptador = new CryptoStream(
                        stream,
                        rijndael.CreateDecryptor(chaveByte, bIV),
                        CryptoStreamMode.Write);
  
                    descriptador.Write(valorByte, 0, valorByte.Length);           
                    descriptador.FlushFinalBlock();       
                    UTF8Encoding utf8 = new UTF8Encoding();     
                    return utf8.GetString(stream.ToArray());
                }
                else
                {              
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao descriptografar", ex);
            }

        }
    }
}
