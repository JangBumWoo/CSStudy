#6_SQL 연습문제

# 6-1
CREATE DATABASE `OrderDB`;
CREATE USER 'master'@'%' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON OrderDB.* TO 'master'@'%';
FLUSH PRIVILEGES;

# 6-2
CREATE TABLE `Customer` (
`custId` VARCHAR (10) PRIMARY KEY,
`name` VARCHAR (10) NOT NULL,
`hp` VARCHAR (13) UNIQUE,
`addr` VARCHAR (100),
`rdate` DATE NOT NULL 
);

DROP TABLE `Customer`;

CREATE TABLE `Product` (
`prodNo` TINYINT PRIMARY KEY,
`ProdName` VARCHAR (10) NOT NULL,
`stock` TINYINT,
`price` INT,
`company` VARCHAR (10) NOT NULL 
);

DROP TABLE `Product`;

CREATE TABLE `Product` (
`prodNo` TINYINT PRIMARY KEY,
`ProdName` VARCHAR (10) NOT NULL,
`stock` INT DEFAULT 0,
`price` INT,
`company` VARCHAR (10) NOT NULL 
);

CREATE TABLE `Order` (
`orderNo` TINYINT PRIMARY KEY,
`orderId` VARCHAR (10) NOT NULL,
`orderProduct` TINYINT NOT NULL,
`orderCount` TINYINT NOT NULL DEFAULT 1,
`orderDate` DATETIME NOT NULL 
);

DROP TABLE `Order`


INSERT INTO `Customer` VALUES ('heoj', '허준',  NULL, NULL, '2022-01-07');
INSERT INTO `Customer` VALUES ('jang', '장보고',  '010-1234-1003', '완도군 청산면', '2022-01-03');
INSERT INTO `Customer` VALUES ('jeongc', '정철',  '010-1234-1006', '경기도 용인시', '2022-01-06');
INSERT INTO `Customer` VALUES ('jeongyy', '정약용',  '010-1234-1010', '경기도 광주시', '2022-01-10');
INSERT INTO `Customer` VALUES ('kang', '강감찬',  '010-1234-1004', '서울시 마포구', '2022-01-04');
INSERT INTO `Customer` VALUES ('kimcc', '김춘추',  '010-1234-1002', '경주시 보문동', '2022-01-02');
INSERT INTO `Customer` VALUES ('kimys', '김유신',  '010-1234-1001', '김해시 봉황동', '2022-01-01');
INSERT INTO `Customer` VALUES ('leesg', '이성계',  NULL , NULL, '2022-01-05');
INSERT INTO `Customer` VALUES ('leess', '이순신',  '010-1234-1008', '서울시 영등포구', '2022-01-08');
INSERT INTO `Customer` VALUES ('songsh', '송상현',  '010-1234-1009', '부산시 동래구', '2022-01-09');
orderdb

INSERT INTO `Order` VALUES (1, 'kimcc',  3, 2, '2022-07-01 13:15:10');
INSERT INTO `Order` VALUES (2, 'kimys',  4, 1, '2022-07-01 14:16:11');
INSERT INTO `Order` VALUES (3, 'leess',  1, 1, '2022-07-01 17:12:18');
INSERT INTO `Order` VALUES (4, 'songsh',  6, 5, '2022-07-02 10:46:36');
INSERT INTO `Order` VALUES (5, 'kimcc',  2, 1, '2022-07-03 09:15:37');
INSERT INTO `Order` VALUES (6, 'kimys',  7, 3, '2022-07-03 12:35:12');
INSERT INTO `Order` VALUES (7, 'jeongyy',  1, 2, '2022-07-03 16:55:36');
INSERT INTO `Order` VALUES (8, 'kang',  2, 4, '2022-07-04 14:23:23');
INSERT INTO `Order` VALUES (9, 'kimcc',  1, 3, '2022-07-04 21:54:34');
INSERT INTO `Order` VALUES (10, 'heoj',  6, 1, '2022-07-05 14:21:03');

SELECT * FROM `Customer`;
SELECT `custid`, `name`, `hp` FROM `Customer`;
SELECT * FROM `Product`;

# 6-8 제품 테이블에서 제조업체를 중복없이 조회
SELECT DISTINCT `company` 
FROM `Product`;
// DISTINCT: 중복 제거의 역할

SELECT FROM `Product`;

SELECT `prodName`,`price` 
FROM `Product`;

# 실습 6-10 제품 테이블에서 제품명과 단가를 조회하되, 단가에 500원을 더해 `조정단가`로 출력  
SELECT `prodName`, `price`+500 AS `조정단과`
FROM `product`;

# 실습 6-11 제품 테이블에서 오리온이 제조한 제춤의 제품명, 재고량, 단가 조회
SELECT `prodName`, `stock`, `price` 
FROM `product` 
WHERE `company` = '오리온';

# 실습 6- 12 주문 테이블에서 kimcc 고객이 주문한 제품, 수량, 주문일자 조회
SELECT `orderProduct`, `orderCount`, `orderDate` 
FROM `order`
WHERE `orderId` = 'kimcc';

# 6-13 주문 테이블에서 kimcc 고객이 2개 이상 주문한 주문 제품, 수량, 주문일자
SELECT `orderProduct`, `orderCount`, `orderDate` 
FROM `order`  WHERE `orderId` = 'kimcc'
AND `orderCount` >= 2;

# 6-14 제품 테이블에서 단가가 1000 이상 2000 이해인 제품 조회
SELECT * FROM `product` WHERE 1000 <= `price` AND `price` <= 2000;

# 6-15 고객 테이블에서 성이 김씨인 고객의 아이디, 이름, 휴대폰 주소 조회
SELECT `custid`, `name`, `hp`, `addr` FROM `customer` 
WHERE `name` LIKE '김%';

#6-16 고객  테이블에서 고객 아이디가 4자인 고객의 아이디, 이름, 휴대폰, 주소 조히
SELECT `custid`, `name`, `hp`, `addr` FROM `customer` 
WHERE `custid` LIKE '____';

#6-17 고객 테이블에서 휴대폰 번호가 입력되지 않는 고객을 조회
SELECT*FROM `customer` WHERE `hp` IS NULL;

#6-18 고객 테이블에서 주소가 입력된 고객
SELECT*FROM `customer` WHERE `addr` IS NOT NULL;

#6-19 고객 테이블에서 가입일을 내림차순으로 정렬하여 고객 조회
SELECT*FROM `customer` ORDER BY `rdate` DESC;

#6-20
SELECT*FROM `order` WHERE `orderCount` >=3 
ORDER BY `orderCount` DESC, `orderProduct` ASC; 

 
# 6-21
SELECT AVG(`price`) FROM `product`;

# 6-22
SELECT SUM(`stock`) AS `재고량 합계` FROM `product` WHERE `company` = '농심';
 
# 6-23
SELECT COUNT(`custid`) AS `고객수` FROM `customer`;




# 6-24
SELECT COUNT(DISTINCT `company` ) AS `제조업체 수` FROM `product`;

# 6-25
SELECT `orderProduct` AS `주문 상품번호`, 
SUM(`orderCount`) AS `총 주문수량`
FROM `order` GROUP BY `orderProduct`, `orderId`;
# 6-26
# 6-27
#6-28
# 6-29
# 6- 30





 
user2