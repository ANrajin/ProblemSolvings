#include <bits/stdc++.h>

using namespace std;

int main()
{
    ios::sync_with_stdio(0);
    cin.tie(0);

    // remove before submit
    freopen("input.txt", "r", stdin);
    freopen("output.txt", "w", stdout);

    // Your code start here
    int T;
    cin >> T;
    cin.ignore();

    while (T--)
    {
        string str;
        int count = 1;
        getline(cin, str);

        for (auto s : str)
        {
            if (s == ' ')
                count++;
        }

        cout << "Count = " << count;
        if (T > 0)
            cout << "\n";
    }

    return 0;
}