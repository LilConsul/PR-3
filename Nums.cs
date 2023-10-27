namespace PR_3 {
    public class Nums {
        private readonly int a, b, c;

        public Nums(int a, int b, int c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double DoTask() {
            //Якщо хоча б одне число менше 15 - повернути сер. арифм.
            //В іншому випадку - сумму
            return (a, b, c) switch {
                _ when a < 15 || b < 15 || c < 15 => (a + b + c) / 3,
                _ => a + b + c
            };
        }
    }
}