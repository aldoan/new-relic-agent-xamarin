# New Relic Agent For Xamarin
New Relic Agent For Xamarin

## Installation
The Agent to Instrument New Relic in Xamarin is available on a NuGet Package called NewRelicAgentForXamarin https://www.nuget.org/packages/NewRelicAgentForXamarin/. 

To start Install the NuGet Package via Manage Nuget Packages under the Tools menu for Windows and under the Project menu on Mac.

### iOS:
Open `AppDelegate.cs` and add the following to the top of the file:

```
using NewRelicXamarin;
```

Next, inside the class AppDelegate you need to add the following to the `FinishedLaunching` function:

```
NRLogger.SetLogLevels((uint)NRLogLevels.All);
NewRelicXamarin.NewRelic.StartWithApplicationToken("new_relic_license_key");
```

Make sure you replace the `new_relic_license_key` with your own. You can find your own license key by creating a Mobile app within the New Relic UI. Go to `Mobile` > `Add a new app` > Choose your platform > Give your App a name > Your license key is now visible lower down the page.


### Android:
In the MainActivity class or equivalent

```
var config = new NewRelicXamarin.Android.AgentConfiguration();
config.ApplicationToken = "new_relic_license_key";
NewRelicXamarin.Android.AndroidAgentImpl.Init(this, config);
NewRelicXamarin.Android.Agent.Start();

```

Make sure you replace the `new_relic_license_key` with your own.


## Custom Events with Attributes

For sending Custom events we use the method `RecordCustomEvent` included in the package, sending as parameters an event name and optionally we can send custom Attributes:

```
NewRelicXamarin.NewRelic.RecordCustomEvent(eventType, attributes);

```

## BreadCrumbs


## Crash Report
