private static void printseries(int n) {
    Arraylist arr = new Arraylist();

    for (int i = 1; i <= n; i++) {
        for (int j = i; j <= i; j++) {
            if (arr.count == n) {
                Console.WriteLine(string.Join(",", arr.ToArray()));
                return;
            } else {
                arr.Add(i);
            }
        }

    }

    //Print 
