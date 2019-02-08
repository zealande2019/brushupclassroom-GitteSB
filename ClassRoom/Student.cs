using System;

public class Studenter
{
    public Student()
    {
        {
            private string _navn;
            private int _fødselsmåned;
            private int _fødselsdag;

        }
    

        
         public Studenter (string navn, int fødselsmåned, int fødselsdag)
        {
        _navn = navn;
        _fødselsmåned = fødselsmåned;
        _fødselsdag = fødselsdag;
        }
        public string Navn
        {
        get { return _navn; }
        }
        
        public int Fødselsdag
        {
            get { return _fødselsdag; }

        }

         public int Fødselsmåned
        {  
                get { return _fødselsmåned; }

        }
public void PrintInformation(string header)
        {
        Console.WriteLine(header);
        Console.WriteLine($"{Navn} er født {Fødselsdag} i {Fødselsmåned");

        }
    }
}
