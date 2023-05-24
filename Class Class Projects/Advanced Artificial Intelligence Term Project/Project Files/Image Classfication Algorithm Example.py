
import tensorflow as tf
import numpy as np 

filename = '/2021-2022 School Year 2nd Semester/Adv Artifical Inteligence\Term Project/Images To Classify/Cat85.jpg'

##Second Method to load an image
from tensorflow.keras.preprocessing import image
img = image.load_img(filename, target_size = (224,224))

import matplotlib.pyplot as plt 

plt.imshow(img)

# Lets load the deep learning model

mobile = tf.keras.applications.mobilenet.MobileNet() ## deep Learning model weights - pre-trained

## Creating a model
## Training a modle
## test or validate
# Predict

mobile = tf.keras.applications.mobilenet_v2.MobileNetV2()

## Pre-processing of the image
#filename = '/2021-2022 School Year 2nd Semester/Adv Artifical Inteligence/Term Project/Images To Classify/Cat2.jpg'
from tensorflow.keras.preprocessing import image
img = image.load_img(filename, target_size = (224, 224))

plt.imshow(img)

resized_img = image.img_to_array(img)
final_image = np.expand_dims(resized_img,axis =0) ## need fourth dimension
final_image=tf.keras.applications.mobilenet.preprocess_input(final_image)

final_image.shape

predictions = mobile.predict(final_image)

from tensorflow.keras.applications import imagenet_utils
results = imagenet_utils.decode_predictions(predictions)

print(results)


