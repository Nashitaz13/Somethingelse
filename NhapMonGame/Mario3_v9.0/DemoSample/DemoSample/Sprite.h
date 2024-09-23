#pragma once
#ifndef __Sprite_H__
#define __Sprite_H__

#include <d3dx9.h>
#include "GlobalObject.h"

// M?i ??i t??ng Sprite s? l?u m?t h�nh l?n
// ??i t??ng Sprite n�y s? v? frame trong h�nh ?�
class CSprite
{
public:
	LPDIRECT3DTEXTURE9 Texture;

public:
	CSprite::CSprite(LPCSTR FilePath);	// Khoi tao doi tuong Sprite bang cach truyen vao duong dan tuong ung
	~CSprite();
	void Render(int x, int y, RECT rect); 	// Ve hinh	
	void DrawItem(int x, int y, RECT rect); 	// Ve hinh	
};

#endif
