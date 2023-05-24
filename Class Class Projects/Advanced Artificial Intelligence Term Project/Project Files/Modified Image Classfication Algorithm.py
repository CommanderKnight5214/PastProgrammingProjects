import tensorflow as tf
import numpy as np 
from tensorflow.keras.preprocessing import image


def ImageClassificationFunction (ImageListArray, counter):
    counter = counter;
    for x in range(len(ImageListArray)):
        filename = ImageListArray[x]
        
        ##Second Method to load an image
        from tensorflow.keras.preprocessing import image
        img = image.load_img(filename, target_size = (224,224))
        
        #plt.imshow(img)
        
        # Lets load the deep learning model
        
        mobile = tf.keras.applications.mobilenet.MobileNet() ## deep Learning model weights - pre-trained
        
        ## Creating a model
        ## Training a modle
        ## test or validate
        # Predict
        
        mobile = tf.keras.applications.mobilenet_v2.MobileNetV2()
        
        ## Pre-processing of the image
        
        img = image.load_img(filename, target_size = (224, 224))
        
        #plt.imshow(img)
        
        resized_img = image.img_to_array(img)
        final_image = np.expand_dims(resized_img,axis =0) ## need fourth dimension
        final_image=tf.keras.applications.mobilenet.preprocess_input(final_image)
        
        final_image.shape
        
        predictions = mobile.predict(final_image)
        
        from tensorflow.keras.applications import imagenet_utils
        results = imagenet_utils.decode_predictions(predictions)
        
        print("\n")
        print("Cat Image: ")
        print(counter)
        print("\n")
        print(results)
        counter = counter + 1;
        

StringArray = []

StringArray.append('/2021-2022 School Year 2nd Semester/Adv Artifical Inteligence\Term Project/Images To Classify/Cat196.jpg')
StringArray.append('/2021-2022 School Year 2nd Semester/Adv Artifical Inteligence\Term Project/Images To Classify/Cat197.jpg')
StringArray.append('/2021-2022 School Year 2nd Semester/Adv Artifical Inteligence\Term Project/Images To Classify/Cat198.jpg')
StringArray.append('/2021-2022 School Year 2nd Semester/Adv Artifical Inteligence\Term Project/Images To Classify/Cat199.jpg')
StringArray.append('/2021-2022 School Year 2nd Semester/Adv Artifical Inteligence\Term Project/Images To Classify/Cat200.jpg')

counter = 196
ImageClassificationFunction(StringArray, counter)


