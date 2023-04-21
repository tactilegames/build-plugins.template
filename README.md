# Build Plugins Template

This project is a template for creating Build plugins. By using this template, you can quickly set up and configure your custom Build plugins with ease.

## Installation and Usage

To install and use this template, run the following command:

```bash
git clone git@github.com:tactilegames/build-plugins.template.git build-plugins.PLUGIN_NAME && ./build-plugins.PLUGIN_NAME/setup.sh
```

Once the repository has been cloned, the `setup.sh` script will be executed. This script will trigger a Command Line Interface (CLI) tool where you will be prompted to provide the following information:

1. **Plugin name**: The name of your Build plugin.
2. **GitHub repository URL**: The URL of your plugin's GitHub repository.

After providing the required arguments, the CLI tool will configure the template project by replacing all placeholders with the provided plugin name and GitHub repository URL. Your new Build plugin project is now ready to use!

## Getting Started

After completing the setup process, you can start working on your Build plugin. Use the provided structure as a starting point and modify it to fit your plugin's requirements.

Remember to update the `README.md` file in your plugin's repository to include specific information about your plugin, such as its purpose, features, installation, and usage instructions.

## Contributing

If you find any issues or have suggestions for improvements, feel free to create an issue or submit a pull request in the [template repository](https://github.com/tactilegames/build-plugins.template).