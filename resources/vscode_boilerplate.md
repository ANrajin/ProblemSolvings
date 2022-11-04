# VS Code CPP Boilerplate

```
{
	// Place your snippets for cpp here. Each snippet is defined under a snippet name and has a prefix, body and 
	// description. The prefix is what is used to trigger the snippet and the body will be expanded and inserted. Possible variables are:
	// $1, $2 for tab stops, $0 for the final cursor position, and ${1:label}, ${2:another} for placeholders. Placeholders with the 
	// same ids are connected.
	// Example:
	"boilerplate": {
		"prefix": "cpp",
		"body": [
			"#include <bits/stdc++.h>",
			"",
			"using namespace std;",
			"",
			"int main()",
			"{",
			"\tios::sync_with_stdio(0);",
			"\tcin.tie(0);",
			"",
			"\t// remove before submit",
			"\tfreopen(\"input.txt\",\"r\", stdin);",
			"\tfreopen(\"output.txt\",\"w\", stdout);",
			"",
			"\t// If you think it's simple, then you have misunderstood the problem ;)",
			"",
			"\treturn 0;",
			"}"
		],
		"description": "The default C++ boilerplate for competitive programming"
	}
}
```
