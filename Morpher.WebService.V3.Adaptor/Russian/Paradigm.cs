﻿using System;
using Morpher.Russian;

namespace Morpher.WebService.V3.Russian.Adaptor
{  
    class Paradigm : IParadigm
    {
        public const char Separator = '\uffff';

        readonly NumberSpellingResult r;

        public Paradigm(NumberSpellingResult r)
        {
            this.r = r;
        }
                
        public string Nominative => r.NumberDeclension.Nominative + Separator + r.UnitDeclension.Nominative;
        public string Genitive => r.NumberDeclension.Genitive + Separator + r.UnitDeclension.Genitive;
        public string Dative => r.NumberDeclension.Dative + Separator + r.UnitDeclension.Dative;
        public string Accusative => r.NumberDeclension.Accusative + Separator + r.UnitDeclension.Accusative;
        public string Instrumental => r.NumberDeclension.Instrumental + Separator + r.UnitDeclension.Instrumental;
        public string Prepositional => r.NumberDeclension.Prepositional + Separator + r.UnitDeclension.Prepositional;
        public string Locative => throw new NotImplementedException();
    }    
}
