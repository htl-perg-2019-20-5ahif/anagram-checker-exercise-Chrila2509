using Backend;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Reader : IReader
    {
        private ILogger logger;
        private IConfiguration config;

        public Reader(IConfiguration config, ILogger<Reader> logger)
        {
            this.config = config;
            this.logger = logger;
        }

        public async Task<string> ReadDictionary()
        {
            string dictionaryText;

            try
            {
                var dictFile = config["dictionaryFileName"];
                dictionaryText = await System.IO.File.ReadAllTextAsync(dictFile);
            } catch (FileNotFoundException ex)
            {
                logger.LogError(ex, "Dictionary not found!");
                throw;
            }
            return dictionaryText;
        }
    }
}
