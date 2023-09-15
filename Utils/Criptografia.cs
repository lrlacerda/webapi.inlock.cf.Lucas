namespace webapi.inlock.cf.Lucas.Utils
{
    public static class Criptografia
    {
        /// <summary>
        /// Gera uma Hash apartir de uma senha
        /// </summary>
        /// <param name="senha">Senha e receberá a Hash </param>
        /// <returns>Senha Criptografada com a Hash</returns>
        public static string GerarHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        /// <summary>
        /// Verifica se a senha da hash informada é igual a hash salva no banco de dados
        /// </summary>
        /// <param name="senhaForm">senha informada pelo usuário</param>
        /// <param name="senhaBanco">senha cadastrada no banco</param>
        /// <returns>True ou False (senha é verdadeira)</returns>
        public static bool CompararHash(string senhaForm, string senhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaBanco);
        }
    }
}
