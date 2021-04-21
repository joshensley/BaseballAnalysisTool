using Firebase.Auth;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAnalysisTool.Data
{
    public class FirebaseData
    {
        public static string ApiKey = "AIzaSyAYwLslWAGiJXPDkjmDidkj60TITaLS-bE";
        public static string Bucket = "baseballanalysistool.appspot.com";
        public static string AuthEmail = "joshensley@gmail.com";
        public static string AuthPassword = "Admin123!";




        // NOTE: This will not work. Only an example.

        /*public async static Task<string> GetTeamLogoDownloadUrlAsync(string firebaseTeamLogoImageName)
        {
            var auth = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));
            var a = await auth.SignInWithEmailAndPasswordAsync(AuthEmail, AuthPassword);

            var firebaseDownloadUrl = new FirebaseStorage(
                Bucket,
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                    ThrowOnCancel = true
                })
                .Child("defaultBaseballTeamLogo")
                .Child($"{firebaseTeamLogoImageName}")
                .GetDownloadUrlAsync().Result;

            return firebaseDownloadUrl;
        }*/

    }
}
