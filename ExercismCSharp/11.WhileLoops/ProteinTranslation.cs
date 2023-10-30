namespace ExercismCSharp;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        Dictionary<string, string> codonToAminoAcid = new()
        {
            {"AUG", "Methionine"},
            {"UUU", "Phenylalanine"},
            {"UUC", "Phenylalanine"},
            {"UUA", "Leucine"},
            {"UUG", "Leucine"},
            {"UCU", "Serine"},
            {"UCC", "Serine"},
            {"UCA", "Serine"},
            {"UCG", "Serine"},
            {"UAU", "Tyrosine"},
            {"UAC", "Tyrosine"},
            {"UGU", "Cysteine"},
            {"UGC", "Cysteine"},
            {"UGG", "Tryptophan"},
            {"UAA", "STOP"},
            {"UAG", "STOP"},
            {"UGA", "STOP"}
        };

        List<string> result = new();
        int index = 0;

        while (index < strand.Length - 2)
        {
            string codon = strand.Substring(index, 3);

            if (codonToAminoAcid.ContainsKey(codon))
            {
                string aminoAcid = codonToAminoAcid[codon];

                if (aminoAcid == "STOP")
                {
                    break;
                }

                result.Add(aminoAcid);
            }

            index += 3;
        }

        return result.ToArray();
    }
}