# COMP5530M-Group-1
## INDOOR CAMPUS NAVIGATOR APP
-----
### 1. Project Overview

The **Indoor Campus Navigator app** assists users in navigating indoors using real-time directions and augmented reality. The app utilizes the camera on a mobile device to overlay directional indicators, helping users reach classrooms, offices, or other facilities across the university campus.

-----
### 2. Key Features
- **Augmented Reality Navigation**:

  ARCore-powered directions help users visually follow a path to their destination.
- **Indoor Mapping**:

  Accurate navigation within campus buildings, supported by real-time updates on user location.
- **Cloud Storage and Backend Support**:

  Google Cloud services provide data storage, retrieval, and user authentication.
- **Cross-Platform Support**:

  The app is designed to work on both Android and iOS (with future ARKit compatibility).
  
-----
### 3. Tech Stack
- **React Native**: main framework for cross-platform mobile development
- **ARCore**: augmented reality framework for Android
- **Google Cloud**: Backend services and cloud storage (Cloud Firestore, Google Cloud Functions, Firebase)

---
### 4. Pre-requisites
- **Node.js** and **npm**
- **Android Studio**: for Android SDK and emulator
- **Java Development Kit (JDK)**: for Android builds
- **React Native CLI**: for initialising and managing the project
- **Google Cloud Account**: compose and manage backend and cloud services

---
### 5. Setup
  >1. Clone the Repository
  ```
  git@github.com:Smarties123/COMP5530M-Group-1.git
  cd indoor-campus-navigator
  ```
  >2. Install Dependencies
  ```
  npm install
  ```
  >3. Set Up Environment Variables
-  Create a .env file in the root directory and add your environment variables

  ```
GOOGLE_CLOUD_API_KEY = your_google_cloud_api_key
ARCORE_API_KEY = your_arcore_api_key
```

-  Install react-native-dotenv to handle environment variables

```
npm install react-native-dotenv
```

>4. Android Setup
-   Open Android Studio, set up the Android SDK, and start an emulator or connect a device.
-   In your terminal, run:
```
npx react-native run-android
```
>5. Start the Metro Bundler
```
npx react-native start
```
-----
