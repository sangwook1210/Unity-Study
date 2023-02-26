# Bamsongi

● 게임 스크린샷 / 플레이 영상<br>

![KakaoTalk_20230226_223640701_03](https://user-images.githubusercontent.com/112921582/221416931-ae0732ae-107c-4c87-8399-5b010153cc18.jpg)

https://youtu.be/bj5UwFEKsJ0<br>

● 게임 소개<br>

화면을 터치하여 밤송이를 발사해 과녁에 적중시키는 게임

● 게임 기획

- 과녁에 Collider 설정
- 밤송이가 중력에 영향을 받도록 Rigidbody와 Collider 설정
- `OnCollisionEcter(Collision other)`를 통하여 밤송이와 과녁의 충돌을 감지한 후 `GetComponent<Rigidbody>.isKinematic = true;`를 통하여 밤송이를 정지시킴
- GetMouseButtonDown(0)을 통하여 화면을 터치하면 고양이가 점프하도록 설정
- 고양이의 y축 속도가 0일 때문에만 점프가 가능하도록 설정하여 점프가 연속으로 되지 않도록 설정
- 걷기와 점프 행동을 할 때 애니메이션 재생
- 구름에는 Collider, Rigidbody, Kinematic을, 고양이에는 Collider와 Rigidbody를 적용하여 서로가 충돌하고 고양이는 중력에 영향을 받도록 설정
- 카메라가 플레이어를 따라다니도록 CameraController 스크립트를 통하여 설정
- 일정거리 이하로 떨어지면 처음부터 다시 시작
- 고양이가 깃발에 도착한다면 ClearScene으로 전환


● 실행 환경

Android, Galaxy S10 5G<br>
