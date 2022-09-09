using Microsoft.VisualBasic;
using System.Security.AccessControl;
using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SwagLabsClassLib
{
    public class Program
    {
       
        public static string SwagLabUrl;
        public static string Browser;
        public static string username;
        public static string lockedoutuser;
        public static string problemuser;
        public static string performanceglitchuser;
        public static string password;
        public static string Firstname;
        public static string LastName;
        public static string Pincode;

        static Program(){

        var configurationBuilder = new ConfigurationBuilder ();
        configurationBuilder.SetBasePath (Directory.GetCurrentDirectory ());
        configurationBuilder.AddJsonFile (@"C:\mitra c#\SwagLabs\SwagLabsClassTest\Test.json", optional : true, reloadOnChange : true);
        IConfigurationRoot configuration = configurationBuilder.Build ();
       
        SwagLabUrl = configuration.GetSection ("ConnectionStrings:Url").Value;
        Browser = configuration.GetSection ("ConnectionStrings:Browser").Value;
        username = configuration.GetSection ("ConnectionStrings:username").Value;
        lockedoutuser = configuration.GetSection ("ConnectionStrings:lockedoutuser").Value;
        problemuser = configuration.GetSection ("ConnectionStrings:problemuser").Value;
        performanceglitchuser = configuration.GetSection ("ConnectionStrings:performanceglitchuser").Value;
        password = configuration.GetSection ("ConnectionStrings:password").Value;
        Firstname = configuration.GetSection ("ConnectionStrings:FirstName").Value;
        LastName = configuration.GetSection ("ConnectionStrings:LastName").Value;
        Pincode = configuration.GetSection ("ConnectionStrings:Pincode").Value;

         }    
    
} 
    }
