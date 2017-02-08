# Microsoft Azure Exam 70-534 Prep
## Azure Functions demo code

### About this repository
The code in this repository is that used for the demonstration of Azure Functions in Linux Academy's Microsoft Azure Exam 70-534 Prep course, located at https://linuxacademy.com/cp/modules/view/id/94

You can fork, clone or download this code to replicate the demonstration.

*Important note: Your Linux Academy subscription does not include Azure services or credits.* If you want to run this demo code yourself, you must have your own Azure subscription, and you may be billed for the services you use. if so, you will be billed directly by Microsoft. Your Linux Academy subscription does _not_ include Azure credits.

### About the code
This code has three folders. Two of those folders represent the Azure Functions code itself. A third folder contains an ARM template you can use to provision the Azure resources needed to run this demo.

*QueueTimer*: This folder contains the configuration (function.json) and runtime (run.csx) files for an Azure Function that places a message on an Azure Storage queue once per minute.

*randomword*: This folder contains the configuration (function.json) and runtime (run.csx) files for an Azure Function that responds to HTTP GET and POST requests with a plain-text word chosen at random.

*template* This folder contains an ARM template (azuredeploy.json) and parameters file (parameters.json) to deploy the resources needed for this demo.

### Running the ARM template
You can execute the ARM template using the portal, CLI, PowerShell or REST API.

Note that if you choose to use the parameters.json file to provide the value for your install, you must _first_ change the values for name, storageName and subscriptionId in that file. 

Also, if you want to use a different region that South Central US for your deployment, you must change that to be one of the predefined Azure region names, available at https://azure.microsoft.com/en-us/regions/