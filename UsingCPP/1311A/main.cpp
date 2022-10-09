#include <iostream>

using namespace std;

int main()
{
    long long t, a, b, c, x;

    cin >> t;

    while (t--)
    {
        cin >> a >> b;

        if (a < b)
        {
            x = b - a;
            c = x % 2 == 0 ? 2 : 1;
            cout << c << endl;
        }
        else if (a > b)
        {
            x = a - b;
            c = x % 2 == 0 ? 1 : 2;
            cout << c << endl;
        }
        else
        {
            cout << 0 << endl;
            continue;
        }
    }

    return 0;
}
