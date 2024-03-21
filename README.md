
# react-native-race-motor-extreme-performance

## Getting started

`$ npm install react-native-race-motor-extreme-performance --save`

### Mostly automatic installation

`$ react-native link react-native-race-motor-extreme-performance`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-race-motor-extreme-performance` and add `RNRaceMotorExtremePerformance.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNRaceMotorExtremePerformance.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNRaceMotorExtremePerformancePackage;` to the imports at the top of the file
  - Add `new RNRaceMotorExtremePerformancePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-race-motor-extreme-performance'
  	project(':react-native-race-motor-extreme-performance').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-race-motor-extreme-performance/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-race-motor-extreme-performance')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNRaceMotorExtremePerformance.sln` in `node_modules/react-native-race-motor-extreme-performance/windows/RNRaceMotorExtremePerformance.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Race.Motor.Extreme.Performance.RNRaceMotorExtremePerformance;` to the usings at the top of the file
  - Add `new RNRaceMotorExtremePerformancePackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNRaceMotorExtremePerformance from 'react-native-race-motor-extreme-performance';

// TODO: What to do with the module?
RNRaceMotorExtremePerformance;
```
  