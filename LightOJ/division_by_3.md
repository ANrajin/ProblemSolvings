# [Division By 3](https://lightoj.com/problem/division-by-3)
```
#include <bits/stdc++.h>

using namespace std;

int divBy3(int n)
{
    if (n == 0)
        return 0;

    int x;

    if (n % 3 == 0)
        x = n / 3;
    else
        x = (n / 3) + 1;

    return n - x;
}

int main()
{
    ios::sync_with_stdio(0);
    cin.tie(0);

    int t, cs = 1;
    cin >> t;
    cin.ignore();
    while (t--)
    {
        long long a, b, result;
        cin >> a >> b;

        result = divBy3(b) - divBy3(a - 1);

        cout << "Case " << cs++ << ": " << result << "\n";
    }
    return 0;
}
```