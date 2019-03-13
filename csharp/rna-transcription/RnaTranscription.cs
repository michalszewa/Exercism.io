using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        string result = "";

        foreach (char c in nucleotide)
        {
            switch(c)
            {
                case 'G':
                    result = result + 'C';
                    break;
                case 'C':
                    result = result + 'G';
                    break;
                case 'T':
                    result = result + 'A';
                    break;
                case 'A':
                    result = result + 'U';
                    break;
            }
        }
        return result;
    }
}