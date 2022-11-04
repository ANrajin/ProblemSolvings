# [Optimal Prime](https://www.codechef.com/problems/PRIME1)

> print all prime numbers in a certain range
<br>
> solved using sieve algorithm

```
#include <bits/stdc++.h>

using namespace std;

bool prime(long long n)
{
    if (n <= 1) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;

    int i = 3;

    while (i * i <= n)
    {
        if (n % i == 0) return false;

        i += 2;
    }

    return true;
}

int main()
{
    ios::sync_with_stdio(0);
    cin.tie(0);

    int t;
    cin >> t;

    while (t--)
    {
        long long n, m;
        cin >> n >> m;

        for (int i = n; i <= m; i++)
        {
            if (prime(i))
                cout << i << "\n";
        }
    }

    return 0;
}
```
