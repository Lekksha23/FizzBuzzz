namespace FizzBuzz.Entities
{
    public class BaseFizz
    {
        public List<object> _resultList;
        protected List<int> _inputList;
        protected int _length;

        protected string _fizzBuzz = "fizz-buzz";
        protected string _fizz = "fizz";
        protected string _buzz = "buzz";

        public BaseFizz(List<int> inputList)
        {
            _inputList = inputList;
            _length = inputList.Count;
            _resultList = new List<object>();
            inputList.ForEach(x => _resultList.Add(x));
        }

        public virtual List<object> ReplaceNumbers()
        {
            return _resultList;
        }
    }
}
