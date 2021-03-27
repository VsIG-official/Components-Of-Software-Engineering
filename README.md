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
/// Test public property FilePath
/// Check if we get exact string as it is in constructor
/// </summary>
[Fact]
public void FilePath_None_ReturnsSameString()
{
	// Arrange
	const string FULL_PATH = @"D:\ForStudy\Components-Of-" +
		@"Software-Engineering\Labs\Lab2\Lab2\TempFile.txt";
	FileWorker worker = new(FULL_PATH);

	string expected = worker.FilePath;

	// Act
	string actual = @"D:\ForStudy\Components-Of-" +
		@"Software-Engineering\Labs\Lab2\Lab2\TempFile.txt";

	// Assert
	Assert.Equal(actual, expected);
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
