using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brige
{
    class Program
    {
        static void Main(string[] args)
        {
            IDevice tv = new TV();
            RemoteControl tvRemote =  new RemoteControl(tv);
            tvRemote.TurnOn();
            tvRemote.TurnOff();

            IDevice radio = new Radio();
            AdvanceRemoteControl radioRemote = new AdvanceRemoteControl(radio);
            radioRemote.TurnOn();
            radioRemote.SetVolume(100);
            radioRemote.TurnOff();



            IDevice tv2 = new TV();
            RemoteControl tv2Remote = new RemoteControl(tv2);
            radioRemote.TurnOn();
            radioRemote.SetVolume(100);
            radioRemote.TurnOff();

        }
    }

    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void SetVolume(int volume);
        void SwitchForward();
        void SwitchBack();
       
    }
    public class TV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("ваш телик включился");

        }
        public void TurnOff()
        {
            Console.WriteLine("телик выключился");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine("новое значение громкости телика:" + volume);
        }
        public void SwitchForward()
        {
            Console.WriteLine("ваш телик переключился вперед");
        }
       public void SwitchBack()
        {
            Console.WriteLine("ваш телик переключился назад");
        }

        
    }
    public class Radio : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("ваше радио включилось");

        }
        public void TurnOff()
        {
            Console.WriteLine("радио выключилось");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine("новое значение громкости радио:" + volume);
        }

        public void SwitchForward()
        {
            Console.WriteLine("ваше радио переключило частоту вперед");
        }

        public void SwitchBack()
        {
            Console.WriteLine("ваше радио переключило частоту назад ");
        }
    }
    //базовый пульт
    public class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device){
            this.device = device;
        }
        public virtual void TurnOn()
        {
            device.TurnOn();
        }
        public virtual void TurnOff()
        {
            device.TurnOff();
        }


    } 
    //расширенный пульт
    public class AdvanceRemoteControl : RemoteControl
    {

        public AdvanceRemoteControl(IDevice device) : base(device)
        {
        }
        public void SetVolume(int volume)
        {
            device.SetVolume(volume);
        }
    }
    public class AdvanceRemoteControl2 : AdvanceRemoteControl
    {
        public AdvanceRemoteControl2(IDevice device) : base(device)
        {

        }
        public virtual void SwitchForward()
        {
            device.SwitchForward();
        }
        public virtual void SwitchBack()
        {
            device.SwitchBack();
        }
    }

}
