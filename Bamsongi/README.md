# Bamsongi

● 게임 스크린샷 / 플레이 영상<br>

![KakaoTalk_20230226_223640701_03](https://user-images.githubusercontent.com/112921582/221416931-ae0732ae-107c-4c87-8399-5b010153cc18.jpg)

https://youtu.be/bj5UwFEKsJ0<br>

● 게임 소개<br>

화면을 터치하여 밤송이를 발사해 과녁에 적중시키는 게임

● 게임 기획

- 과녁에 Collider 설정
- 밤송이가 중력에 영향을 받도록 Rigidbody와 Collider 설정
- `OnCollisionEcter(Collision other)`를 통하여 밤송이와 과녁의 충돌을 감지한 후, `GetComponent<Rigidbody>.isKinematic = true;`를 통하여 밤송이를 정지시킴
- 파티클을 설정하여 밤송이가 과녁에 충돌하였을 때 파티클이 재생되도록 설정
- `Camera.main.ScreenPointToRay(Input.mousePosition)`을 통하여 카메라에서 스크린 좌표로 향하는 월드 좌표계 벡터를 사용하여 밤송이를 날림


● 실행 환경

Android, Galaxy S10 5G<br>
