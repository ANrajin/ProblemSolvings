#include <bits/stdc++.h>

using namespace std;

int main()
{
    freopen("input.txt", "r", stdin);
    freopen("output.txt", "w", stdout);

    int T;
    scanf("%d", &T);
    cin.ignore();

    while (T--)
    {
        string str, vowels, consonents;
        getline(cin, str);

        for (auto s : str)
        {
            if (s == ' ')
                continue;

            char c = tolower(s);

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                vowels += s;
            else
                consonents += s;
        }

        cout << vowels << "\n";
        cout << consonents << "\n";
    }
    return 0;
}
