# [Is Prime](https://lightoj.com/problem/dimik-is-prime)

>> Using sieve algorithm

```
#include <bits/stdc++.h>

using namespace std;

int main()
{
    ios::sync_with_stdio(0);
    cin.tie(0);

    // If you think it's simple, then you have misunderstood the problem ;)
    int t;
    cin >> t;

    while (t--)
    {
        long long n, i;
        cin >> n;

        if (n <= 1)
        {
            cout << n << " is not a prime\n";
            continue;
        }
        if (n == 2)
        {
            cout << n << " is a prime\n";
            continue;
        }
        if (n % 2 == 0)
        {
            cout << n << " is not a prime\n";
            continue;
        }

        bool isPrime = 1;

        for (i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
            {
                isPrime = 0;
                break;
            }
        }

        if (isPrime)
            cout << n << " is a prime\n";
        else
            cout << n << " is not a prime\n";
    }

    return 0;
}
```
