# ClimbCloud

● 게임 스크린샷 / 플레이 영상<br>
![KakaoTalk_20230226_223640701_01 - 복사본](https://user-images.githubusercontent.com/112921582/221415275-6424fda8-9bd3-4dbe-9f51-69054af87f1d.jpg)                                                    ![KakaoTalk_20230226_223640701 - 복사본](https://user-images.githubusercontent.com/112921582/221415277-ccd5a60d-03b7-4636-a497-1a2895c1cdc8.jpg)



https://youtube.com/shorts/xgjm2OUYTyw<br>

● 게임 소개<br>

스마트폰을 좌우로 기울이거나 터치를 통하여 고양이를 조작하여 구름 위를 올라가는 게임<br>

● 게임 기획

- Input.acceleration.x를 통하여 플레이어가 스마트폰을 기울이는 것을 통하여 고양이를 좌우로 이동하도록 설정
- GetMouseButtonDown(0)을 통하여 화면을 터치하면 고양이가 점프하도록 설정
- 고양이의 y축 속도가 0일 때문에만 점프가 가능하도록 설정하여 점프가 연속으로 되지 않도록 설정
- 걷기와 점프 행동을 할 때 애니메이션 재생
- 구름에는 Collider, Rigidbody, Kinematic을, 고양이에는 Collider와 Rigidbody를 적용하여 서로가 충돌하고 고양이는 중력에 영향을 받도록 설정
- 카메라가 플레이어를 따라다니도록 CameraController 스크립트를 통하여 설정
- 일정거리 이하로 떨어지면 처음부터 다시 시작
- 고양이가 깃발에 도착한다면 ClearScene으로 전환


● 실행 환경

Android, Galaxy S10 5G<br>
