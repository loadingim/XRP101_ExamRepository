# 5번 문제

주어진 프로젝트는 다음의 기능을 구현하고자 생성한 프로젝트이다.

### 01. Main Scene
- 실행 시, Start 버튼을 누르면 게임매니저를 통해 게임 씬이 로드된다.

### 02. Game Scene
- Go to Main을 누르면 메인 씬으로 이동한다
- `+`버튼을 누르면 큐브 오브젝트의 회전 속도가 증가한다
- `-`버튼을 누르면 큐브 오브젝트의 회전 속도가 감소한다 (-가 될 경우 역방향으로 회전한다)
- Popup 버튼을 누르면 게임 오브젝트가 정지(큐브의 회전이 정지)하며, Popup창을 출력한다. 이 때 출력된 팝업창은 2초 후 자동으로 닫힌다.

### 공통 사항
- 게임 실행 중 씬 전환 시에도 큐브 오브젝트의 회전 속도는 저장되어 있어야 한다.

위 기능들을 구현하고자 할 때
제시된 프로젝트에서 발생하는 `문제들을 모두 서술`하고 올바르게 동작하도록 `소스코드를 개선`하시오.

## 답안
- 메인씬 게임씬 둘다 이벤트 시스템이 존재하지않아 버튼이 작동하지 않습니다. > 이벤트 시스템 추가
- 팝업을 눌렀을때 타임 스케일이 0이 되어서wait이 제대로 작동하지 않아 게임 매니저의 Pause함수 변경 > temp 변수를 추가후 타임 스케일을 건드리지 않도록 변경
