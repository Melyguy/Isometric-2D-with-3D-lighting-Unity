
# Isometric 2D scene with 3D-ish lighting

## Heavily inspired by Isocore by JohnBRX https://www.youtube.com/watch?v=UavoVWHrebM&t=10s

![Skjermopptak 2025-11-27 102547.gif](https://raw.githubusercontent.com/bucketio/img1/main/2025/11/27/1764235610831-6b49e42e-fda5-4ef3-868e-d23f1ed63ba4.gif 'Skjermopptak 2025-11-27 102547.gif')


### This project was made so i could learn about isometric tilemaps and making 2d sprites look like they are being lit up in 3d. I did this with the use of normal maps.


----
## Setup

 - First i designed an isometric cube to use in this project. ![newcube.png](https://raw.githubusercontent.com/bucketio/img15/main/2025/11/27/1764231287191-9ac9672a-0222-4f1a-84e9-c81c16964124.png 'newcube.png')
  - I then made a normal map texture for the cube.
    ![normal_map.png](https://raw.githubusercontent.com/bucketio/img11/main/2025/11/27/1764231453770-ded626a9-0bd5-46a9-abb5-06353114f1e8.png 'normal_map.png')

---

## Tilemap

  - I spent some time figuring out how unity's tilemap system and I finally figured out how to make a tilemap of these cubes.
    ![Skjermbilde 2025-11-27 083708.png](https://raw.githubusercontent.com/bucketio/img8/main/2025/11/27/1764231758329-133199d2-6c78-4930-a924-e27efb9abbc2.png 'Skjermbilde 2025-11-27 083708.png')


  - When we now flash a light on the plane we se that the light behaves more 3-dimentional than it did before. We can see that the light travels along the faces instead of lighting up the entire cube

   ![Skjermopptak 2025-11-27 084324.gif](https://raw.githubusercontent.com/bucketio/img16/main/2025/11/27/1764235348334-4b2e919d-960d-4f57-896f-8d2beb552546.gif 'Skjermopptak 2025-11-27 084324.gif')
