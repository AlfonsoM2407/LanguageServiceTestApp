# Language Service Test App

Simple application that queries an Azure language service resource to return the language of a text snippet and its confidence on it being said language.
You will need access to an Azure language service resource to use this app.

## How to use

On execution, the app will ask you for an Azure language service endpoint and its access key. This resource will be the one queried for the rest of the execution. Once you have filled in the required information, click on the "Access Azure Resource" button to proceed.
The window will change to include a text box, in it you may input any form of text. Clicking the "Query" button will create a message box containing:
1. The language Azure thinks the text in the box is in.
2. Its degree of confidence on it being said language as a percentage.

### To be noted

When Azure doesn't recognise a language within a string, it may return "English" with a 100% degree of confidence.