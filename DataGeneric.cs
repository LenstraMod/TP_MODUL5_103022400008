namespace TP_MODUL5_103022400008
{
    public class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data) {
            this.data = data;
        }

        public void PrintData() {
            Console.WriteLine("Data: " + this.data);
        }
    }
}