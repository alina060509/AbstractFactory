using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_настоящая_
{
    class Program
    {
        static void Main(string[] args)
        {
            Light roomlight = new Light();
            ICommand turnOnnCommand = new TurnOnLigntCommand(roomlight);
            ICommand turnOffCommand = new TurnOffLigntCommand(roomlight);
            ICommand replaceCommand = new ReplaceLightCommand(roomlight);

            RemoteControl remote = new RemoteControl();
            remote.SetCommand(turnOnnCommand);
            remote.PressButton();
            remote.SetCommand(replaceCommand);
            remote.PressButton();
            remote.SetCommand(turnOffCommand);
            remote.PressButton();

        }
    }
     public interface ICommand
    {
        void Execute();

    }
    //команда включения света
    public class TurnOnLigntCommand : ICommand
    {
        private Light _lignt;
        public TurnOnLigntCommand(Light lignt)
        {
            _lignt = lignt;
        }
        public void Execute()
        {
            //какой то код
            _lignt.TurnOn();
        }
    }
    //команда выключения света
    public class TurnOffLigntCommand : ICommand
    {
        private Light _lignt;
        public TurnOffLigntCommand(Light lignt)
        {
            _lignt = lignt;
        }
        public void Execute()
        {
            //какой то код
            _lignt.TurnOff();
        }
    }
    //выбор цвета
    public class ReplaceLightCommand : ICommand
    {
        private Light _lignt;
        public ReplaceLightCommand(Light lignt)
        {
            _lignt = lignt;
        }
        public void Execute()
        {
            //какой то код
            _lignt.ReplaceLight();
        }
    }

    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Свет включен");
        }
        public void TurnOff()
        {
            Console.WriteLine("Свет выключен");
        }
        public void ReplaceLight()
        {
            Console.WriteLine("Свет изменен!");
        }
    }

    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;

        }
        public void PressButton()
        {
            _command.Execute();
        }
    }

}
