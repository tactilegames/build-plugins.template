# BuildPlugin.PLUGIN_NAME

# Overview
Provide a 2-3 sentences describing about what the build plugin does.

# Installation
Add in your `nuget.yml`
```yml
dependencies:
  - name: BuildPlugins.PLUGIN_NAME
    version: 0.0.1-alpha.0
```

# Steps

* [PLUGIN_NAMEStep](#plugin_namestep)
* [PLUGIN_NAMEWithOptionsStep](#plugin_namewithoptionsstep)

## PLUGIN_NAMEStep

A brief description about what this step does.

---
## PLUGIN_NAMEWithOptionsStep

A brief description about what this step does.

**Pipeline Values**

| Key       | Type    | Description                          | Default Value  | Required |
| --------- | ------- | ------------------------------------ | -------------- | -------- |
| MESSAGE   | string  | A Message to display in the console  |                | Yes      |
| UPPERCASE | string  | Should the message be in uppercase   | false          |          |

**Example**

```yml
values:
  MESSAGE: "Hello World"
  UPPERCASE: true
```