# Panoramix's Prediction

```
#include <bits/stdc++.h>

using namespace std;

bool is_prime(int x)
{
    if(x < 2) return false;

    for(int i = 2; i*i <= x; i++)
    {
        if(x % i == 0) return false;
    }

    return true;
}

int main()
{
    int n, m, p;

    cin >> n >> m;

    for(int i = n + 1; i <= m; i++)
    {
        if(is_prime(i))
        {
            p = i;
            break;
        }
    }

    if(p == m)
        cout << "YES\n";
    else
        cout << "NO\n";

    return 0;
}
```