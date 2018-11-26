# Bit Radio Button

**BitRadioButton** is a fully customizable control .It supports all Xamarin Forms backends, including but not limited to Android-iOS-Windows(UWP) etc.

### Getting Started

In order to use BitRadioButton, install "Bit.CSharpClient.Controls" nuget package.

### PROPERTIES:
**Key** : (object) 

**Value** : (object) returens value as SelectedItem .

**Text** : Text to display near of RadioButton.

**TextColor** : color of text.

**BorderColor** : color of RadioButton border.

**InerCircleColor** : color of selected RadioButton .

**InerCircleRadius** : (double) radius of iner cirlcle (when RadioButton is selected)

**OuterCircleRadius** : (double) radius of RadioButton

### Use BitRadioButton in Xaml

First of all, add a namepsace to your page:

```
xmlns:bitControls="clr-namespace:Bit.CSharpClient.Controls;assembly=Bit.CSharpClient.Controls"
```
Then use this tag

```xml
<bitControls:BitRadioButton
            Key="{x:Static app:Gender.Man}"
            Text="Man"
            Value="{Binding Person.Gender}" />

``` 
In order to customise text of RadioButton :
```xml
<bitControls:BitRadioButton>
    <Label FontAttributes="Bold" 
        Text="custom label for Radio button. You can also put any custom control here!" />
</bitControls:BitRadioButton>
```
To have better understanding see samples. Feedbacks/issues/questions are also welcomed in [stackoverflow](http://stackoverflow.com/questions/tagged/bit-framework) or [github](https://github.com/bit-foundation/bit-framework/issues/new?labels=&template=bug_report.md).