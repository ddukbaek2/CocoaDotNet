# CocoaDotNet
애플 Cocoa 기반 여러 클래스를 C#으로 만든 더미 클래스 모음입니다.   
Swift, UIKit 등 관련해서 호기심이 생겨서 구조 분석 겸하여 취미삼아 만들어 보려고 합니다.   


## 작성 방침
1. 클래스이름부터 변수명까지 전부 기존 클래스와 동일하게 작성. (스위프트 도큐먼트 보고 그대로 작성)
2. 디렉토리는 네임스페이스 이름, 파일은 실제 클래스 이름으로 작성.
3. 모든 주석은 한글로 작성.
4. Swift의 OptionSet 기반 struct는 C#에서 Enum 비트플래그로 대체.
5. Swift의 protocol은 C#에서 interface로 대체.
6. 레퍼런스타입은 굳이 nullable 표현 하지 않음.
7. Swift의 배열은 C#에서 제네릭 List로 대체.


## 작성 참고
https://developer.apple.com/documentation
