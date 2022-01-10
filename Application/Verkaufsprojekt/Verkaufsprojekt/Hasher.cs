using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Verkaufsprojekt {
    class Hasher {

        public static string sha512(string message) {
            byte[] resultData = SHA512Managed.Create().ComputeHash(Encoding.UTF8.GetBytes(message));
            return ByteArrayToString(resultData);
        }

        public static string sha256(string message) {
            byte[] resultData = SHA256Managed.Create().ComputeHash(Encoding.UTF8.GetBytes(message));
            return ByteArrayToString(resultData);
        }

        public static string md5(string message) {
            byte[] resultData = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(message));
            return ByteArrayToString(resultData);
        }

        public static string ripemd160(string message) {
            byte[] resultData = RIPEMD160Managed.Create().ComputeHash(Encoding.UTF8.GetBytes(message));
            return ByteArrayToString(resultData);
        }

        public static string hashPassword(string id, string password) {
            long time = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            string version = "002:";

            string hash = sha512(id + password + id);
            hash = sha256(hash + id);
            hash = sha512(id + hash + "oaihashgoiaslgh");
            for (int i = 0; i < 6743; i++) {
                hash = sha256(hash + id);
                hash = sha256(hash + id + id);
                hash = sha512(hash);
                if(i == 412) {
                    hash = md5(version + hash + version + id);
                }
                hash = sha512(hash + hash + hash + hash);
                hash = sha512(hash + hash);
                hash = ripemd160(hash);
            }

            for (int i = 0; i < 941; i++) {
                hash = sha512(version + hash);
            }

            hash = ripemd160(version + hash);

            time = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - time;
            Console.WriteLine("Computed password hash in " + time + "ms");

            return version + hash;
        }

        public static string ByteArrayToString(byte[] ba) {
            return BitConverter.ToString(ba).Replace("-", "");
        }

    }
}
