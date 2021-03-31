﻿기능: 레스토랑 리스트 화면 기능 테스트

#@배달주소화면
#시나리오: 요기요 배달 주소 화면 진입
#	먼저 권한 안내 확인 버튼 클릭
#	그리고 시작하기 클릭
#	그리고 권한 동의 클릭
#	그러면 배달 주소 검색 화면 이동
#
#@홈화면
#시나리오: 요기요 홈 화면 진입
#	먼저 권한 안내 확인 버튼 클릭
#	그리고 시작하기 클릭
#	그리고 권한 동의 클릭
#	그러면 배달 주소 검색 화면 이동
#	만일 주소 '서초동 1498-5' 입력
#	그리고 주소가 있다면
#	먼저 검색된 주소 클릭
#	그리고 요기로 배달 버튼 클릭
#	그리고 권한 허용 클릭
#	그러면 요기요 홈 화면 이동
#
#
#	
#@레스토랑화면
#시나리오: 요기요 레스토랑 전체 리스트 화면 이동
#	먼저 권한 안내 확인 버튼 클릭
#	그리고 시작하기 클릭
#	그리고 권한 동의 클릭
#	그러면 배달 주소 검색 화면 이동
#	만일 주소 '서초동 1498-5' 입력
#	그리고 주소가 있다면
#	먼저 검색된 주소 클릭
#	그리고 요기로 배달 버튼 클릭
#	그리고 권한 허용 클릭
#	만일 요기요 홈 화면 이동
#	그리고 음식점 카테고리 전체 클릭
#	그러면 음식점 카테고리 화면 이동 
#
#	
#@레스토랑화면 @익스프레스 체크
#시나리오: 레스토랑 전체 리스트 화면의 익스프레스 필터 체크 
#	먼저 권한 안내 확인 버튼 클릭
#	그리고 시작하기 클릭
#	그리고 권한 동의 클릭
#	그러면 배달 주소 검색 화면 이동
#	만일 주소 '서초동 1498-5' 입력
#	그리고 주소가 있다면
#	먼저 검색된 주소 클릭
#	그리고 요기로 배달 버튼 클릭
#	그리고 권한 허용 클릭
#	만일 요기요 홈 화면 이동
#	그리고 음식점 카테고리 전체 클릭
#	그러면 음식점 카테고리 화면 이동 
#	먼저 요기요 익스프레스 체크

@레스토랑화면 @음식점 안내 클릭
시나리오: 레스토랑 전체 리스트 화면의 음식전 안내 팝업 확인
	먼저 권한 안내 확인 버튼 클릭
	그리고 시작하기 클릭
	그리고 권한 동의 클릭
	그러면 배달 주소 검색 화면 이동
	만일 주소 '서초동 1498-5' 입력
	그리고 주소가 있다면
	먼저 검색된 주소 클릭
	그리고 요기로 배달 버튼 클릭
	그리고 권한 허용 클릭
	만일 요기요 홈 화면 이동
	그리고 음식점 카테고리 전체 클릭
	그러면 음식점 카테고리 화면 이동 
	먼저 음식점 안내 클릭 


	@레스토랑화면 @탭 스크롤
시나리오: 레스토랑 전체 리스트 탭 스크롤
	먼저 권한 안내 확인 버튼 클릭
	그리고 시작하기 클릭
	그리고 권한 동의 클릭
	그러면 배달 주소 검색 화면 이동
	만일 주소 '서초동 1498-5' 입력
	그리고 주소가 있다면
	먼저 검색된 주소 클릭
	그리고 요기로 배달 버튼 클릭
	그리고 권한 허용 클릭
	만일 요기요 홈 화면 이동
	그리고 음식점 카테고리 전체 클릭
	그러면 음식점 카테고리 화면 이동 
	먼저 탭 스크롤
	그러면 기존 선택된 탭 보이지 않는다.


		@레스토랑화면 @탭 변경
시나리오: 레스토랑 전체 리스트 탭 변경
	먼저 권한 안내 확인 버튼 클릭
	그리고 시작하기 클릭
	그리고 권한 동의 클릭
	그러면 배달 주소 검색 화면 이동
	만일 주소 '서초동 1498-5' 입력
	그리고 주소가 있다면
	먼저 검색된 주소 클릭
	그리고 요기로 배달 버튼 클릭
	그리고 권한 허용 클릭
	만일 요기요 홈 화면 이동
	그리고 음식점 카테고리 전체 클릭
	그러면 음식점 카테고리 화면 이동 
	먼저 탭 변경

		@레스토랑화면 @바텀 네비게이션 변경
시나리오: 레스토랑 전체 리스트 바텀 네비게이션 변경
	먼저 권한 안내 확인 버튼 클릭
	그리고 시작하기 클릭
	그리고 권한 동의 클릭
	그러면 배달 주소 검색 화면 이동
	만일 주소 '서초동 1498-5' 입력
	그리고 주소가 있다면
	먼저 검색된 주소 클릭
	그리고 요기로 배달 버튼 클릭
	그리고 권한 허용 클릭
	만일 요기요 홈 화면 이동
	그리고 음식점 카테고리 전체 클릭
	그러면 음식점 카테고리 화면 이동 
	먼저 바텀 네비게이션 변경

@레스토랑화면 @필터 클릭
시나리오: 레스토랑 전체 리스트 필터 팝업
	먼저 권한 안내 확인 버튼 클릭
	그리고 시작하기 클릭
	그리고 권한 동의 클릭
	그러면 배달 주소 검색 화면 이동
	만일 주소 '서초동 1498-5' 입력
	그리고 주소가 있다면
	먼저 검색된 주소 클릭
	그리고 요기로 배달 버튼 클릭
	그리고 권한 허용 클릭
	만일 요기요 홈 화면 이동
	그리고 음식점 카테고리 전체 클릭
	그러면 음식점 카테고리 화면 이동 
	먼저 음식점 필터 클릭
	그러면 음식점 필터 노출
