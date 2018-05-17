﻿using System;
using Morpher.Ukrainian;


namespace Morpher.WebService.V3.Ukrainian.Adaptor
{
    public class NumberSpelling : INumberSpelling
    {
        private MorpherClient _morpher;
        private Client _client;

        public NumberSpelling(Guid? token = null, string url = null)
        {
            _morpher = new MorpherClient(token, url);
            _client = _morpher.Ukrainian;
        }

        public string Spell(decimal n, ref string unit, ICase<IParadigm> @case)
        {
            if (string.IsNullOrEmpty(unit))
                return null;

            var spellResult = _client.Spell(n, unit);

            string [] result = @case.Get(new Paradigm(spellResult))
                .Split(Paradigm.Separator);

            unit = result[1];
            return result[0];
        }
    }
}