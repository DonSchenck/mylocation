# mylocation
Paired with locationms, this web site detects your IP address and your location. For use in demonstrating Kubernetes or OpenShift.

oc new-project csharp

Next, get the locationms service running in OpenShift

From the project home page, select "Deploy Image" option.

Image Name is: quay.io/donschenck/locationms:v2

When that is up and running, deploy the CSharp web site to your cluster:

oc create -f mylocation-deployment.yaml

Create the service:

In the dashboard, open Workloads -> Deployments
Click on mylocation


Create a route:
oc expose service locationms
