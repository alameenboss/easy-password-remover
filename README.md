# Easy Password Remover - PDF Password Removal Tool


**Easy Password Remover** is a Windows Forms application built using the iText 7 NuGet library. This application provides a simple and convenient way to remove passwords from PDF files, allowing users to save the file without any password protection.

## Features

- Remove password protection from PDF files.
- Easy-to-use interface for a seamless user experience.
- Save the PDF file without a password after removal.

## System Requirements

- Windows operating system (tested on Windows 10).
- .NET Framework (minimum version .netcore 6).

## Installation

1. Download the latest release from the [Easy Password Remover releases page](https://github.com/alameenboss/easy-password-remover/releases).
2. Extract the downloaded ZIP archive to a desired location on your computer.

## How to Use

1. Launch the "Easy Password Remover" application.
2. Enter the correct password for the PDF file in the password textbox.
3. Click the **Save in the same folder and append "_unlocked" to the file** checkbox checked if you want to save the unlocked version of the pdf in the same folder, otherwise uncheck to save it in the folder you wanted to save (this will be propmted in the next step)
3. Click on the "Remove Password" button to select the password-protected PDF file you want to remove the password from.
4. Once the password is removed, the application will automatically save the unlocked PDF file to the same location as the original file with "_unlocked" appended to the filename if you have checked otherwise it will be save to the choosen folder.

**Please Note:** Ensure you have the necessary permissions to modify the PDF file before using this tool. Removing passwords from PDF files without the owner's consent may violate copyright and security policies.

## Reporting Issues

If you encounter any issues, bugs, or have suggestions for improvements, feel free to [open an issue](https://github.com/alameenboss/easy-password-remover/issues) on our GitHub repository.

## Contributing

We welcome contributions from the community. If you'd like to contribute to the project, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them with descriptive commit messages.
4. Push your branch to your forked repository.
5. Create a pull request with details about your changes.

## License

Easy Password Remover is licensed under the [MIT License](LICENSE). You are free to use, modify, and distribute this software as per the terms of the license.

## Acknowledgments

We would like to express our gratitude to the developers of the iText 7 library for providing a powerful tool for working with PDF files programmatically.

---

Thank you for choosing Easy Password Remover! We hope this tool simplifies the process of removing passwords from PDF files and enhances your productivity. If you have any questions or feedback, please don't hesitate to contact us.

*For more information, visit our [GitHub repository](https://github.com/alameenboss/easy-password-remover).*