using System;

namespace ConsoleApp4
{
    public class Contribuente
    {
        private string _CognomeContribuente;
        public string CognomeContribuente
        {
            get { return _CognomeContribuente; }
            set { _CognomeContribuente = value; }
        }

        private string _NomeContribuente;
        public string NomeContribuente
        {
            get { return _NomeContribuente; }
            set { _NomeContribuente = value; }
        }

        private decimal _RedditoAnnuale = 0;
        public decimal RedditoAnnuale
        {
            get { return _RedditoAnnuale; }
            set { _RedditoAnnuale = value; }
        }

        private DateTime _DatadiNascita;

        public DateTime DatadiNascita
        {
            get { return _DatadiNascita; }
            set { _DatadiNascita = value; }
        }

        private string _codiceFiscale;
        public string CodiceFiscale
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value; }
        }

        private char _sesso;

        public char Sesso
        {
            get { return _sesso; }
            set { _sesso = value; }
        }

        private string _comuneResidenza;

        public string ComuneResidenza
        {
            get { return _comuneResidenza; }
            set { _comuneResidenza = value; }
        }

        private decimal imposta;
        

        public void GetValidCF()
        {
            string codiceFiscale;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Inserisci il tuo codice fiscale:");
                codiceFiscale = Console.ReadLine();

                if (codiceFiscale.Length != 16)
                {
                    Console.WriteLine("CF non valido");
                    Console.ForegroundColor = ConsoleColor.Red;
                }

            } while (codiceFiscale.Length != 16);
          
            _codiceFiscale = codiceFiscale;  
            _codiceFiscale.ToUpper();
        }

        public void GetName()
        {
            string nome;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Inserisci il tuo nome:");
                nome = Console.ReadLine();

                // Verifica se il nome contiene un numero
                bool contieneNumero = ContieneNumero(nome);

                if (contieneNumero)
                {   Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nome non valido, contiene un numero.");
                    
                }

            } while (ContieneNumero(nome)); // Continua a richiedere il nome finché contiene un numero

            _NomeContribuente = nome;
        }

        public void GetSurname()
        {
            string cognome;

            do
            {   Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Inserisci il tuo cognome:");
                cognome = Console.ReadLine();

                // Verifica se il cognome contiene un numero
                bool contieneNumeroCognome = ContieneNumero(cognome);

                if (contieneNumeroCognome)
                {   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cognome non valido, contiene un numero.");
                    
                }

            } while (ContieneNumero(cognome)); // Continua a richiedere il cognome finché contiene un numero.

            _CognomeContribuente = cognome;
        }

        public void GetCity()
        {
            Console.WriteLine("Inserisci la tua città di residenza:");
            _comuneResidenza = Console.ReadLine();
        }

        public void CheckSex()
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Inserisci il tuo sesso:");
                string inputSesso = Console.ReadLine();

                // Verifico se il sesso inserito è valido, contantato la lunghezza della stringa a 1 e dando la possibilità di mettere anche le lettere in lowercase.
                if (inputSesso.Length == 1 && (inputSesso[0] == 'M' || inputSesso[0] == 'F' || inputSesso[0] == 'f' || inputSesso[0] == 'm'))
                {
                    _sesso = inputSesso[0];
                    break;
                }
                else
                {   Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sesso non valido. Riprova.");
                    
                }

            } while (true);
        }

        bool ContieneNumero(string input)
        {
            foreach (char carattere in input)
            {
                if (char.IsDigit(carattere))
                {
                    return true; // Trovato un numero, ritorna true
                }
            }

            return false; // Nessun numero trovato
        }

        public void CheckData()
        {
            do
            {   Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Inserisci la tua data di nascita:"); //Controllo che la data sia valida sia nel formato sia che l'anno sia quello di un essere umano in vita.

                if (DateTime.TryParse(Console.ReadLine(), out DateTime inputDate))
                {
                    if (inputDate.Year < 1880)
                    {   
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Non esisti più.");
                        
                    }
                    else if (inputDate.Year > 2120)
                    {   
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Non esisti ancora.");
                        
                    }
                    else if (inputDate.Day > 31 || inputDate.Month > 12)
                    {   
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Formato Data non valido.");
                        
                    }
                    else
                    {
                        _DatadiNascita = inputDate;
                        break;
                    }
                }
                else
                {   Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Formato data non valido. Riprova.");
                    
                }

            } while (true);
        }

        public decimal CheckIncome()
        {
            if (RedditoAnnuale <= 15000)
            {
                return RedditoAnnuale * 0.23m;
            }
            else if (RedditoAnnuale <= 28000)
            {
                return 3450 + (RedditoAnnuale - 15000) * 0.27m;
            }
            else if (RedditoAnnuale <= 55000)
            {
                return 6960 + (RedditoAnnuale - 28000) * 0.38m;
            }
            else if (RedditoAnnuale <= 75000)
            {
                return 17220 + (RedditoAnnuale - 55000) * 0.41m;
            }
            else
            {
                return 25420 + (RedditoAnnuale - 75000) * 0.43m;
            }
        }

        public void Details()
        {
            Console.WriteLine("Inserisci il tuo reddito");
            if (decimal.TryParse(Console.ReadLine(), out decimal inputRedditoAnnuale))
            {
                RedditoAnnuale = inputRedditoAnnuale;
                Console.WriteLine("Reddito annuale: $ " + RedditoAnnuale);
                decimal imposta = CheckIncome();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n");
                Console.WriteLine("Imposta da pagare: € " + imposta);
            }
            else
            {
                Console.WriteLine("Errore: Formato reddito non valido.");
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.ReadLine();

            
        }


    }
}
