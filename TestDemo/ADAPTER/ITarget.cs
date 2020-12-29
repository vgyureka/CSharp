namespace TestDemo.ADAPTER
{
    public interface ITarget
    {
        string GetRequest();
    }
    //incomptaible interface with current code
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }
    //Adapter makes Adaptee's interface compatible with target's interface
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}
