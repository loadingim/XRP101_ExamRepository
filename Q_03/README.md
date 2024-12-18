# 3번 문제

주어진 프로젝트 는 다음의 기능을 구현하고자 생성한 프로젝트이다.

### 1. Turret
- Trigger 범위 내로 플레이어가 들어왔을 때 1.5초에 한번씩 플레이어를 바라보면서 총알을 발사한다
- Trigger 범위 바깥으로 플레이어가 나가면 발사를 중지한다.
- 오브젝트 풀을 사용해 총알을 관리한다.

### 2. Bullet :
- 20만큼의 힘으로 전방을 향해 발사된다
- 발사 후 5초 경과 시 비활성화 처리된다
- 플레이어를 가격했을 경우 2의 데미지를 준다

### 3. Player
- 총알과 충돌했을 때, 데미지를 입는다
- 체력이 0 이하가 될 경우 효과음을 재생하며 비활성화된다.
- 플레이어의 이동은 씬 뷰를 사용해 이동하도록 한다.

위 기능들을 구현하고자 할 때
제시된 프로젝트에서 발생하는 `문제들을 모두 서술`하고 올바르게 동작하도록 `소스코드를 개선`하시오.

## 답안
- 1. 터렛이 발사 하지 않는 이유 rigidbody가 없어서 트리거가 작동을 하지 않음 -> rigidbody를 추가
  2. OntriggerEnter로 null에러가 뜨는이유 캐릭터 컨트롤러가 붙어있는 상위 객체에 콜라이더가 없어 Body에 있는 콜라이더와 rigidbody를 상위로 이동
  3. 범위를 바깥으로 이동하여도 총알이 날라오는 이유 코루틴 중지 조건이 없어 Exit를 이용해 범위 바깥으로 나갔을때 발사를 중지. > 조건문이 없으면 총알과도 작동하므로 Player태그 조건문 추가
  4. 사운드가 재생안되는 문제 - 해결못함
