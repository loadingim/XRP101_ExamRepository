# 6번 문제

주어진 프로젝트는 다음의 기능을 구현하고자 생성한 프로젝트이다.

### FPS 조작 구현
- 실행 시, 마우스 커서가 비활성화되며 마우스 회전으로 플레이어의 시야가 회전한다.
- 현재 바라보고 있는 방향 기준으로 W, A, S, D로 전, 후, 좌, 우 이동을 수행한다
- 마우스 좌클릭 시, 시야 정면 방향으로 레이를 발사하고 레이캐스트에 검출된 적의 이름을 콘솔에 로그로 출력한다.

위 기능들을 구현하고자 할 때
제시된 프로젝트에서 발생하는 `문제들을 모두 서술`하고 올바르게 동작하도록 `소스코드를 개선`하시오.

## 답안
- 캠에서 처음보는 함수가 등장...._followTarget.SetPositionAndRotation(transform.position, transform.rotation); 이 부분을 어떻게 작동하는건지 알 수 없어 transform.position = _followTarget.position; transform.rotation = _followTarget.rotation; 부분으로 나누어 작성
- Fire Ray부분은 인자값을 받아오지 않고 캐릭터가 바라보는 방향 정면에서 Ray를 쏘도록 변경
