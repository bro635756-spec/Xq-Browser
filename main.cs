using Microsoft.Win32;
using System;

class ProtocolRegister {
    public static void RegisterXQ() {
        try {
            // xq:// protokolünü sisteme tanıtır
            RegistryKey key = Registry.ClassesRoot.CreateSubKey("xq");
            key.SetValue("", "URL:XQ Protocol");
            key.SetValue("URL Protocol", "");
            
            RegistryKey shell = key.CreateSubKey("shell");
            RegistryKey open = shell.CreateSubKey("open");
            RegistryKey command = open.CreateSubKey("command");
            
            // BurakSearch.exe senin derlediğin main.cpp veya main.cs çıktısı olmalı
            command.SetValue("", "\"C:\\BurakSearch\\main.exe\" \"%1\"");
            
            Console.WriteLine("XQ ve Help protokolleri sisteme kaydedildi.");
        } catch (Exception e) {
            Console.WriteLine("Hata: Yönetici yetkisi gerekebilir. " + e.Message);
        }
    }
}
