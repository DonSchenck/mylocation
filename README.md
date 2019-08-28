# mylocation
Paired with locationms, this web site detects your IP address and your location. For use in demonstrating Kubernetes or OpenShift.

## Create your project in OpenShift
It *must* be called 'test' for this demo.

`oc new-project test` at the command line

OR

Use the dashboard to create the new project 'test'.

## Get the locationms service running in OpenShift

From the project home page, select "Deploy Image" option.

Image Name is: quay.io/donschenck/locationms:v2

Accept all of the warnings and defaults values and click the "Deploy" button.

## Get the C# web site up and running

From the "Catalog" section of the left-hand menu, choose "Developer Catalog".
Select the ".NET Core" catalog.
Click "Create Application"
Use "mylocation" (no quotes) as the name.
Use "https://github.com/donschenck/mylocation.git" as the Git Repository.
Select the "Create route" checkbox.
Click the "Create" button.
