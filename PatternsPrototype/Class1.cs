
namespace PatternsPrototype
{
    public class Milk
    {
        public int Price;
        public int ExpirationDate;
        public string Name;
        public IdInfo IdInfo;

        public Milk IncompleteCopy()
        {
            return (Milk)this.MemberwiseClone();
        }

        public Milk CompleteCopy()
        {
            Milk clone = (Milk)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = String.Copy(Name);
            return clone;
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }

}
