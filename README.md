# App in the Air Widget SDK for Universal Windows Platform (UWP)
This SDK allows create and build widgets for App in the Air Travel Platform

Contains custom control AAWidget which follows our design guidelines.

For example (XAML):
```xml 

<aaWidgetSdk:AAWidget Background="White" PicPath="Assistant.png"/>

```

PicPath - path to pic of widget (rounded)

This control has Content property which allows add any UI elements or controls:
```xml
        <aaWidgetSdk:AAWidget Background="White" PicPath="Assistant.png">
            <aaWidgetSdk:AAWidget.Content>
                <Grid>
			<!--Your content-->
		</Grid>
            </aaWidgetSdk:AAWidget.Content>
        </aaWidgetSdk:AAWidget>
```

AAWidgetSDK also contains our model of data - Trip, FlightInfo, Airport and etc. Some sample data located Model -> SampleModel.cs

#How use
Clone this solution and add reference to AAWidgetSDK to your project
