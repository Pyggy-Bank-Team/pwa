using Nexus.Interfaces;

namespace Nexus.Services
{
    public class DummySettings : ISettingsService
    {
        public void AddOrUpdateValue(string key, string value)
        {
        }

        public bool TryGetValue(string key, out string value)
        {
            value = "";
            return true;
        }

        public string GetValue(string key)
        {
            return "";
        }

        public void RemoveValue(string key)
        {
        }

        public bool HaveValue(string key)
        {
            return true;
        }
    }
}