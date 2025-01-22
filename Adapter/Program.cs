using System;
{//непорождающий 
//namespace Adapter
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //старый код
//            Oldprinter oldprinter = new Oldprinter();
//            //адаптер
//            INewPrinter adapter = new PrinterAdapter(oldprinter);
//            //новый код
//            PrinterClient printerClient = new PrinterClient(adapter);

//            printerClient.PrintMessage("приветик");
//        }
//    }
//    public class Oldprinter
//    {
//        public void PrintOld(string message)
//        {
//            Console.WriteLine("старый принтер: " + message);
//        }
//    }
//    public interface INewPrinter
//    {
//        void Print(string message);
//    }
//    public class PrinterAdapter : INewPrinter
//    {
//        private readonly Oldprinter _printer;
//        public PrinterAdapter(Oldprinter oldprinter)
//        {
//            _printer = oldprinter;
//        }
//        public void Print(string message)
//        {
//            _printer.PrintOld(message);
//        }
//    }
//    public class PrinterClient
//    {
//        private readonly INewPrinter _printer;
//        public PrinterClient(INewPrinter printer)
//        {
//            _printer = printer;
//        }
//        public void PrintMessage(string message)
//        {
//            _printer.Print(message);
//        }
//    }
//}



namespace Adapter
{    
    class Program
    {
        static void Main(string[] args)
        {
            //старый код
            Oldlibrary oldprinter = new Oldlibrary();
            //адаптер
            INewLibrary adapter = new LibraryAdapter(oldprinter);
            //новый код
            PrinterClient printerClient = new PrinterClient(adapter);

            printerClient.PrintMessage("приветик");
        }
    }
    public class Oldlibrary
    {
        public void PrintOld(string message)
        {
            Console.WriteLine("название: " + message + "автор:" + message);
        }
    }
    public interface INewLibrary
    {
        void GetBooks(string message);
    }
    public class LibraryAdapter : INewLibrary
    {
        private readonly Oldlibrary _library;
        public LibraryAdapter(Oldlibrary oldlibrary)
        {
            _library = oldprinter;
        }
        public void Print(string message)
        {
            _printer.PrintOld(message);
        }
    }
    public class PrinterClient
    {
        private readonly INewLibrary _printer;
        public PrinterClient(INewLibrary printer)
        {
            _printer = printer;
        }
        public void PrintMessage(string message)
        {
            _printer.Print(message);
        }
    }
}
