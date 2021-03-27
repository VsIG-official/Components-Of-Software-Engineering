# Components-Of-Software-Engineering

<p align="center">
  <img src="https://github.com/VsIG-official/Components-Of-Software-Engineering/blob/master/Images/test.png" data-canonical-src="https://github.com/VsIG-official/Components-Of-Software-Engineering/blob/master/Images/test.png" />
</p>

## Table of Contents

- [Description](#description)
- [Badges](#badges)
- [Contributing](#contributing)
- [License](#license)

### Description

This repo was created for subject "Components Of Software Engineering" and have My labs

## Badges

> [![Theme](https://img.shields.io/badge/Theme-Testing-blue?style=flat-square)](https://en.wikipedia.org/wiki/Software_testing)
> [![Language](https://img.shields.io/badge/Language-CSharp-purple?style=flat-square)](https://en.wikipedia.org/wiki/C_Sharp_(programming_language))
> [![License](http://img.shields.io/:License-MIT-blue.svg?style=flat-square)](http://badges.mit-license.org)

---

## Example (Optional)

```csharp
/// <summary>
	/// Class for Api Client
	/// </summary>
	public static class ApiHelper
	{
		// Create static, 'cause We need one client per application
		public static HttpClient ApiClient { get; set; }

		/// <summary>
		/// Initializes API client
		/// </summary>
		public static void Initialize()
		{
			ApiClient = new HttpClient
			{
				// a lot of adresses will begin with the same string,
				// so We can put the beginning here
				// but won't, because We need more than one adress
				/*
				BaseAddress = new Uri("http://somesite.com/")
				*/
			};
			ApiClient.DefaultRequestHeaders.Accept.Clear();
			// give Us json, not webpage or etc.
			ApiClient.DefaultRequestHeaders.Accept.Add(new
				MediaTypeWithQualityHeaderValue("application/json"));
		}
	}
```

---

## Contributing

> To get started...

### Step 1

- 🍴 Fork this repo!

### Step 2

- **HACK AWAY!** 🔨🔨🔨

---

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright 2021 © <a href="https://github.com/VsIG-official" target="_blank">VsIG</a>.
