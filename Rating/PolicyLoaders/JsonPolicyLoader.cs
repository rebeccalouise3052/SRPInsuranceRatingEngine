using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Rating.Models;
using Rating.Interfaces;

namespace Rating.PolicyLoaders
{
    // JsonPolicyLoader is responsible ONLY for:
    // - Reading the policy.json file
    // - Deserializing it into a Policy object
    // - Logging errors if something goes wrong
    //
    // It does NOT perform validation.
    // It does NOT perform rating.
    // It does NOT know anything about raters.
    //
    // Pure SRP.
    public class JsonPolicyLoader : IPolicyLoader
    {
        private readonly ILogger _logger;
        private readonly string _filePath;

        // Constructor injection for logger and file path.
        public JsonPolicyLoader(ILogger logger, string filePath = "policy.json")
        {
            _logger = logger;
            _filePath = filePath;
        }

        public Policy LoadPolicy()
        {
            try
            {
                _logger.Log("Loading policy from JSON file...");

                if (!File.Exists(_filePath))
                {
                    _logger.Log($"ERROR: File not found at path '{_filePath}'.");
                    return null;
                }

                string json = File.ReadAllText(_filePath);

                // Deserialize JSON → Policy object
                var policy = JsonConvert.DeserializeObject<Policy>(
                    json,
                    new StringEnumConverter());  // ensures "Auto", "Land", "Life" convert to enum

                _logger.Log("Policy successfully loaded.");
                return policy;
            }
            catch (Exception ex)
            {
                _logger.Log($"ERROR while loading policy: {ex.Message}");
                return null;
            }
        }
    }
}
