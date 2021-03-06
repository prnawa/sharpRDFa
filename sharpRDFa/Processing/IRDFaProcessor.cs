﻿using System.Collections.Generic;
using sharpRDFa.RDFa;

namespace sharpRDFa.Processing
{
    public interface IRDFaProcessor
    {
        NameSpace IsNameSpace(string attributeName);
        List<string> MatchRegEx(string attributeValue, string pattern);
        CURIE IsCURIE(string attributeValue, string vocabulary, IDictionary<string, string> uriMappings);
        CURIE IsSafeCURIE(string attributeValue, string vocabulary, IDictionary<string, string> uriMappings);
        string IsURI(string attributeValue, string attributeName);
        URI GetURIParsed(string attributeValue);
        object IsUriOrSafeCurie(string attributeValue, string vocabulary, IDictionary<string, string> uriMappings, string attributeName);
        string IsReservedWord(string attributeValue);
        object IsReservedWordOrCurie(string attributeValue, IDictionary<string, string> uriMappings);
        IList<CURIE> GetCURIEs(string attributeValue, string vocabulary, IDictionary<string, string> uriMappings);
        string CURIEtoURI(string curie, IDictionary<string, string> uriMappings);
        string SafeCURIEtoURI(string curie, string vocabulary, IDictionary<string, string> uriMappings);
        string ResolveCURIE(string curie, string baseURI, IDictionary<string, string> uriMappings);
        string ResolveSafeCURIE(string curie, string baseURI, string vocabulary, IDictionary<string, string> uriMappings);
        string ResolveURI(string anURI, string baseURI);
        string GetURISchema(string uri);

        string ExpandCurie(IDictionary<string, string> prefixMappings, string vocab, string value);
        string ResolveURI(IDictionary<string, string> prefixMappings, string vocab, IDictionary<string, string> terms, string value);
        IList<string> ProcessUriList(string typedResource, string defaultVocabulary, IDictionary<string, string> prefixMappings);
    }
}
